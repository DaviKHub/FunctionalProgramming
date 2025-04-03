open System

let favLanguage (language:string)=
    match language with
    | "F#"| "Prolog"->"Подлиза"
    | "C" -> "Странное решение"
    | _ -> "Не знаю такого"
    
    
let main (args)=
     favLanguage args

let LP lang=
    (System.Console.ReadLine>>favLanguage>>System.Console.WriteLine)()
    
LP()