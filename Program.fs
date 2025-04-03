let rec reduce (number:int) (func:int->int->int) (initNumber:int) =
    match number with
    | 0 -> initNumber
    | _ ->
        let digit  = number % 10
        let newInitNumber = func initNumber digit
        reduce (number/10) func newInitNumber

let main ()=
    
    System.Console.WriteLine("Минимальное {0}",reduce 123 (fun a b -> match a with | _ when a<=b->a | _ -> b) 10)
    System.Console.WriteLine("Произведение {0}",reduce 123 (fun a b->a*b)  1)
    System.Console.WriteLine("Количество чисел {0}", reduce 123 (fun _ a->a+1) 0)

main()



    