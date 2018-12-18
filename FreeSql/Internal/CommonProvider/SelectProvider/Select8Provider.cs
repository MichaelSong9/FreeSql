﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FreeSql.Internal.CommonProvider {

	abstract partial class Select8Provider<T1, T2, T3, T4, T5, T6, T7, T8> : Select0Provider<ISelect<T1, T2, T3, T4, T5, T6, T7, T8>, T1>, ISelect<T1, T2, T3, T4, T5, T6, T7, T8>
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
		where T8 : class {

		public Select8Provider(IFreeSql orm, CommonUtils commonUtils, CommonExpression commonExpression, object dywhere) : base(orm, commonUtils, commonExpression, dywhere) {
			if (_orm.CodeFirst.IsAutoSyncStructure) _orm.CodeFirst.SyncStructure(typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8));
		}

		TMember ISelect<T1, T2, T3, T4, T5, T6, T7, T8>.Avg<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TMember>> column) => this.InternalAvg<TMember>(column?.Body);

		ISelect<T1, T2, T3, T4, T5, T6, T7, T8> ISelect<T1, T2, T3, T4, T5, T6, T7, T8>.GroupBy(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, object>> columns) => this.InternalGroupBy(columns?.Body);

		TMember ISelect<T1, T2, T3, T4, T5, T6, T7, T8>.Max<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TMember>> column) => this.InternalMax<TMember>(column?.Body);

		TMember ISelect<T1, T2, T3, T4, T5, T6, T7, T8>.Min<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TMember>> column) => this.InternalMin<TMember>(column?.Body);

		ISelect<T1, T2, T3, T4, T5, T6, T7, T8> ISelect<T1, T2, T3, T4, T5, T6, T7, T8>.OrderBy<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TMember>> column) => this.InternalOrderBy(column?.Body);

		ISelect<T1, T2, T3, T4, T5, T6, T7, T8> ISelect<T1, T2, T3, T4, T5, T6, T7, T8>.OrderByDescending<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TMember>> column) => this.InternalOrderByDescending(column?.Body);

		TMember ISelect<T1, T2, T3, T4, T5, T6, T7, T8>.Sum<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TMember>> column) => this.InternalSum<TMember>(column?.Body);

		List<TReturn> ISelect<T1, T2, T3, T4, T5, T6, T7, T8>.ToList<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>> select) => this.InternalToList<TReturn>(select?.Body);

		ISelect<T1, T2, T3, T4, T5, T6, T7, T8> ISelect<T1, T2, T3, T4, T5, T6, T7, T8>.Where(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>> exp) => this.Where(_commonExpression.ExpressionWhereLambda(_tables, exp?.Body));

		ISelect<T1, T2, T3, T4, T5, T6, T7, T8> ISelect<T1, T2, T3, T4, T5, T6, T7, T8>.WhereIf(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>> exp) => condition ? this.Where(_commonExpression.ExpressionWhereLambda(_tables, exp?.Body)) : this;

		ISelect<T1, T2, T3, T4, T5, T6, T7, T8> ISelect<T1, T2, T3, T4, T5, T6, T7, T8>.WhereLike(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, string[]>> columns, string pattern, bool notLike) => this.InternalWhereLikeOr(columns?.Body, pattern, notLike);

		ISelect<T1, T2, T3, T4, T5, T6, T7, T8> ISelect<T1, T2, T3, T4, T5, T6, T7, T8>.WhereLike(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, string>> column, string pattern, bool notLike) => this.InternalWhereLike(column?.Body, pattern, notLike);
	}
}