namespace SINNIKA.EFCore.Initialize.Types {
public enum ConditionType
    {
        Unknown,
        Not,
        Equal,
        NotEqual,
        GreaterThan,
        GreaterThanEqual,
        LessThan,
        LessThanEqual,
        NotLike,
        Like,
        InsensitiveLike,
        NotInsensitiveLike,
        InsensitiveUnidecodeLike,
        NotInsensitiveUnidecodeLike,
        StartsWith,
        EndsWith,
        Regex,
        And,
        Or
    }
}