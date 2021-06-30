﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Datacom.IRIS.DomainModel.Domain;
using Datacom.IRIS.DomainModel.Domain.AutoGenerated;
using System.Data.Objects;
using Datacom.IRIS.Common.Utils;
using System.Reflection;
using System.Web.UI.WebControls;

namespace Datacom.IRIS.DataAccess.Utils
{
    public static class QueryableExtensions
    {
        private static Expression<Func<TElement, bool>> GetWhereInExpression<TElement, TValue>(Expression<Func<TElement, TValue>> propertySelector, IEnumerable<TValue> values)
        {
            ParameterExpression p = propertySelector.Parameters.Single();
            if (!values.Any()) return e => false;

            var equals = values.Select(value => (Expression)Expression.Equal(propertySelector.Body, Expression.Constant(value, typeof(TValue))));
            var body = equals.Aggregate<Expression>((accumulate, equal) => Expression.Or(accumulate, equal));

            return Expression.Lambda<Func<TElement, bool>>(body, p);
        }

        /// <summary>  
        ///    Return the element that the specified property's value is contained in the specifiec values  
        /// </summary>  
        /// <typeparam name="TElement">The type of the element.</typeparam>  
        /// <typeparam name="TValue">The type of the values.</typeparam>  
        /// <param name="source">The source.</param>  
        /// <param name="propertySelector">The property to be tested.</param>  
        /// <param name="values">The accepted values of the property.</param>  
        /// <returns>The accepted elements.</returns>  
        public static IQueryable<TElement> WhereIn<TElement, TValue>(this IQueryable<TElement> source, Expression<Func<TElement, TValue>> propertySelector, params TValue[] values)
        {
            return source.Where(GetWhereInExpression(propertySelector, values));
        }

        /// <summary>  
        ///    Return the element that the specified property's value is contained in the specifiec values  
        /// </summary>  
        /// <typeparam name="TElement">The type of the element.</typeparam>  
        /// <typeparam name="TValue">The type of the values.</typeparam>  
        /// <param name="source">The source.</param>  
        /// <param name="propertySelector">The property to be tested.</param>  
        /// <param name="values">The accepted values of the property.</param>  
        /// <returns>The accepted elements.</returns>  
        public static IQueryable<TElement> WhereIn<TElement, TValue>(this IQueryable<TElement> source, Expression<Func<TElement, TValue>> propertySelector, IEnumerable<TValue> values)
        {
            return source.Where(GetWhereInExpression(propertySelector, values));
        }

        public static IQueryable<TSource> WhereIfSet<TSource>(this IQueryable<TSource> source, string value, Expression<Func<TSource, bool>> predicate)
        {
            return !string.IsNullOrEmpty(value) ? source.Where(predicate) : source;
        }

        public static IEnumerable<TSource> WhereIfSet<TSource>(this IEnumerable<TSource> source, string value, Func<TSource, bool> predicate)
        {
            return !string.IsNullOrEmpty(value) ? source.Where(predicate) : source;
        }

        /// <summary>
        ///    Turns on entity tracking for each elements in list
        /// </summary>
        public static List<TSource> TrackAll<TSource>(this List<TSource> source) where TSource : class, IDomainObjectBase
        {
            source.ForEach(e => e.TrackAll());
            return source;
        }

        /// <summary>
        ///    Turns entity tracking on for each element provided and returns self. Note,
        ///    that this method uses a special iterator that is created by a T4 template to 
        ///    iterate and start tracking on all child entities inside the current entity
        ///    provided
        /// </summary>
        public static TSource TrackAll<TSource>(this TSource source) where TSource : class, IObjectWithChangeTracker
        {
            if (source != null)
            {
                IRISContextIterator.Execute(source, (IObjectWithChangeTracker e) => e.StartTracking());
            }

            return source;
        }

        /// <summary>
        ///     Adds all elements in a list individually through a for-each statement. If the target list belongs
        ///     to an entity that is tracking, this technique will ensure that list range being added will also
        ///     have their tracking turned on
        /// </summary>
        public static void AddRange<T>(this TrackableCollection<T> collection, List<T> fromList)
        {
            fromList.ForEach(u => collection.Add(u));
        }

        public static ObjectQuery<T> Include<T>(this ObjectQuery<T> query, Expression<Func<T, object>> exp) where T : class
        {
            //var memberExpression = (exp.Body as UnaryExpression).Operand as MemberExpression;
            var memberExpression = exp.Body as MemberExpression;
            return query.Include(memberExpression.GetRecursiveMemberName());
        }

        public static IOrderedQueryable<T> SortBy<T>(this IQueryable<T> source,
            string sortExpression, SortDirection sortDirection) where T : class
        {
            bool sortDescending = false;
            if (string.IsNullOrEmpty(sortExpression))
                throw new ArgumentNullException("sortExpression", "SortExpression cannot be null or empty");

            if (sortDirection == SortDirection.Descending)
                sortDescending = true;

            Type sortColumnType;
            LambdaExpression keySelectorExpression = GetSelectorExpression<T>(sortExpression, out sortColumnType);

            // Our parameters into the function - this is used for the main function
            var sourceParam = Expression.Parameter(typeof(IQueryable<T>), "source");

            // Which method do we use for sorting?
            var sortExpressionMethodName = sortDescending ? "OrderByDescending" : "OrderBy";

            // Now call the OrderByMethod
            var sortExpressionCall =
                Expression.Call(
                    typeof(Queryable),
                    sortExpressionMethodName,
                    new Type[] { typeof(T), sortColumnType },
                    sourceParam,
                    keySelectorExpression);

            // Compile our expression
            var del = (Func<IQueryable<T>, IOrderedQueryable<T>>)(Expression.Lambda(sortExpressionCall, sourceParam).Compile());

            // And run it...
            IOrderedQueryable<T> sorted = del(source);
            return sorted;
        }


        public static IOrderedEnumerable<T> SortBy<T>(this IEnumerable<T> source,
            string sortExpression, SortDirection sortDirection) where T : class
        {
            bool sortDescending = false;
            if (string.IsNullOrEmpty(sortExpression))
                throw new ArgumentNullException("sortExpression", "SortExpression cannot be null or empty");

            if (sortDirection == SortDirection.Descending)
                sortDescending = true;

            Type sortColumnType;
            LambdaExpression keySelectorExpression = GetSelectorExpression<T>(sortExpression, out sortColumnType);

            // Our parameters into the function - this is used for the main function
            var sourceParam = Expression.Parameter(typeof(IEnumerable<T>), "source");

            // Which method do we use for sorting?
            var sortExpressionMethodName = sortDescending ? "OrderByDescending" : "OrderBy";

            // Now call the OrderByMethod
            var sortExpressionCall =
                Expression.Call(
                    typeof(Enumerable),
                    sortExpressionMethodName,
                    new Type[] { typeof(T), sortColumnType },
                    sourceParam,
                    keySelectorExpression);

            // Compile our expression
            var del = (Func<IEnumerable<T>, IOrderedEnumerable<T>>)(Expression.Lambda(sortExpressionCall, sourceParam).Compile());

            // And run it...
            IOrderedEnumerable<T> sorted = del(source);
            return sorted;
        }
        /// <summary>
        /// Uses parameter and parameter type to create a lambda of x => x.parameter
        /// </summary>
        /// <typeparam name="T">The type to sort.</typeparam>
        /// <param name="paramter">The parameter expression</param>
        /// <param name="parameterType">the type of the parameter</param>
        /// <returns>a LambdaExpression of x=>x.parameter nature</returns>
        private static LambdaExpression GetSelectorExpression<T>(string parameter, out Type sortColumnType) where T : class
        {
            // This is the parameter into our keySelector
            ParameterExpression param = Expression.Parameter(typeof(T), "item");

            /*
             * Create a lamdaexpression property that returns a given property name from the current
             * T generic that is being used with this class. We also support nested SortExpressions
             * (e.g. Objector.DisplayValue) by splitting a parameter and retriving the value of the 
             * deepest property.
             * 
             * This will allow us to sort on a BoundField or a TemplateField as follows:
             *    <asp:BoundField SortExpression="" />
             * Lam  bda to select a key, does x => x.SortExpressionProperty
             */
            LambdaExpression keySelectorExpression;
            string[] parts = parameter.Split('.');

            Type expressionType = typeof(T);
            Expression expression = param;
            for (int i = 0; i < parts.Length; i++)
            {
                expressionType = GetParameterType<T>(expressionType, parts[i]);
                expression = Expression.Convert(Expression.Property(expression, parts[i]), expressionType);
            }

            keySelectorExpression = Expression.Lambda(expression, param);
            sortColumnType = expressionType;

            keySelectorExpression.Compile();
            return keySelectorExpression;
        }

        /// <summary>
        /// Searches type T for parameter and returns it's type.
        /// </summary>
        /// <typeparam name="T">The type to search.</typeparam>
        /// <param name="parameter">The parameter to look for.</param>
        /// <returns>The type of the paramter</returns>
        private static Type GetParameterType<T>(Type parameterType, string parameter) where T : class
        {
            //OK it gets a little tricky here.  Basically we do a bit of reflection
            // to find the type of the property being sorted and then order by that
            PropertyInfo propertyInfo = parameterType.GetProperty(parameter,
                BindingFlags.Public | BindingFlags.Instance);

            if (propertyInfo == null)
                throw new ApplicationException(string.Format("Sort Expression '{0}' not found in type {1}", parameter, parameterType));

            parameterType = propertyInfo.PropertyType;
            return parameterType;
        }

        public static Expression<Func<T, object>> GetExpression<T>(string propertyName) where T : class
        {
            // This is the parameter into our keySelector
            ParameterExpression param = Expression.Parameter(typeof(T), "item");

            /*
             * Create a lamdaexpression property that returns a given property name from the current
             * T generic that is being used with this class. We also support nested SortExpressions
             * (e.g. Objector.DisplayValue) by splitting a parameter and retriving the value of the 
             * deepest property.
             * 
             * This will allow us to sort on a BoundField or a TemplateField as follows:
             *    <asp:BoundField SortExpression="" />
             * Lam  bda to select a key, does x => x.SortExpressionProperty
             */
            //LambdaExpression keySelectorExpression;
            string[] parts = propertyName.Split('.');

            Type expressionType = typeof(T);
            Expression expression = param;
            for (int i = 0; i < parts.Length; i++)
            {
                expressionType = GetParameterType<T>(expressionType, parts[i]);
                expression = Expression.Convert(Expression.Property(expression, parts[i]), expressionType);
            }

            return Expression.Lambda<Func<T,object>>(expression, param);
            
            //var param = Expression.Parameter(typeof(T), "x");
            //Expression conversion = Expression.Convert(Expression.Property
            //    (param, propertyName), typeof(object));   //important to use the Expression.Convert
            //return Expression.Lambda<Func<T, object>>(conversion, param);
        }

        //makes deleget for specific prop
        public static Func<T, object> GetFunc<T>(string propertyName) where T : class
        {
            return GetExpression<T>(propertyName).Compile();  //only need compiled expression
        }

        //OrderBy overload
        public static IOrderedEnumerable<T> 
            OrderByExpressionOrderedEnumerable<T>(this IEnumerable<T> source, string propertyName, SortDirection sortDirection) where T : class
        {
            if(sortDirection == SortDirection.Ascending)
                return source.OrderBy(GetFunc<T>(propertyName));
            else
                return source.OrderByDescending(GetFunc<T>(propertyName));
            
        }

        //OrderBy overload
        public static IOrderedQueryable<T>
            OrderByExpressionOrderedQueryable<T>(this IQueryable<T> source, string propertyName, SortDirection sortDirection) where T : class
        {
            if (sortDirection == SortDirection.Ascending)
                return source.OrderBy(GetExpression<T>(propertyName));
            else
                return source.OrderByDescending(GetExpression<T>(propertyName));
        }
    }
}
