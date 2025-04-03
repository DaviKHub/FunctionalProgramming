let favLangue (langue:string)=
    match langue with
    | "F#"| "Prolog"->"Подлиза"
    | "C" -> "Странное решение"
    | _ -> "Не знаю такого"
    
    
let main (args)=
     System.Console.WriteLine( favLangue args)

main(System.Console.ReadLine())