namespace Dapper.Oracle
{
    /// <summary>
    /// Maps Oracle native numeric values (especially <c>OracleDecimal</c>) to <see cref="decimal"/>,
    /// using <c>OracleDecimal.SetPrecision(..., 28)</c> before reading <c>System.Decimal</c> (same idea as legacy ADO.NET).
    /// </summary>
    /// <remarks>
    /// Used internally by <see cref="OracleValueConverter"/> (for example from <see cref="OracleDynamicParameters.Get{T}"/>).
    /// Dapper's default <c>Query&lt;decimal&gt;</c> / <c>ExecuteScalar&lt;decimal&gt;</c> does not call this; for result sets use this helper on raw values, SQL <c>CAST</c>, or a custom <c>TypeHandler</c>.
    /// </remarks>
    public static class OracleDecimalConversion
    {
        public static decimal ToDecimal(object value) => OracleValueConverter.Convert<decimal>(value);

        public static decimal? ToDecimalNullable(object value) => OracleValueConverter.Convert<decimal?>(value);
    }
}
