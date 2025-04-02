let sumOfDigits n=
    let rec sumDigits n curSum =
        match n with
         | 0 -> curSum
         | _ ->
             let n1 = n/10
             let cifr = n%10
             sumDigits n1 (curSum + cifr)
    sumDigits n 0

let factorial n=
    let rec mul n curMul =
        match n with
        | 0 | 1 -> curMul
        | _ -> mul(n-1) (curMul*n)
    mul n 1

let isLogicalFunc logicVar numericVar =
    match logicVar with
    | true -> sumOfDigits numericVar
    | false -> factorial numericVar

let main () =
        System.Console.WriteLine(isLogicalFunc false 12)
        System.Console.WriteLine(isLogicalFunc true 12)
main()