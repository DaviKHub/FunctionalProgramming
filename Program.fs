let rec reduceBy (number:int) (func:int->int->int) (initialAcc:int) (predicate:int->bool)=
    match abs(number) with
    | 0 -> initialAcc
    | _ ->
        let digit  = abs(number) % 10
        let newAcc =
            match predicate digit with
            | true -> func initialAcc digit
            | false -> initialAcc
        reduceBy (abs(number)/10) func newAcc predicate

let isPrime (number:int)=
    let rec divisor (num:int) (div:int)=
        match div*div>num, num%div=0 with
        | true, _ -> true
        | _, true -> false
        | _ -> divisor num (div+1)
    match number with
    | _ when number<=1 -> false
    | 2 -> true
    | _ when number%2=0 -> false
    | _  -> divisor number 3
    
    
let main ()=
    
    System.Console.WriteLine("Максимальное нечетное: {0}",reduceBy 123456789 (fun a b -> match a with | _ when a>=b->a | _ -> b) -1 (fun d -> d%2=1))
    System.Console.WriteLine("Произведение простых: {0}",reduceBy 123456789 (*) 1 (fun d -> isPrime d=true))
    System.Console.WriteLine("Количество чисел кратных 5: {0}", reduceBy 123456789 (fun a _ -> a+1) 0 (fun d -> d%5=0))

main()