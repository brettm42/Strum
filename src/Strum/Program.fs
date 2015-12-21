namespace Strum

module Console =     
    open Strum
    open System

    [<EntryPoint>]
    let main argv = 
        
        let notes = List.map Note

        let strings = notes [E 4; A 4; D 4; G 4; B 4; E 4;]

        let CM = chord C M strings
        let Cm = chord C m strings
        let Dm7 = chord D m7 strings
        let FM7 = chord F M7 strings
        let Am9 = chord A m9 strings

        printfn "C major"
        printTab CM strings

        printfn "\r\nC minor"
        printTab Cm strings

        printfn "\r\nD minor 7th"
        printTab Dm7 strings

        printfn "\r\nF major 7th"
        printTab FM7 strings

        printfn "\r\nA minor 9th"
        printTab Am9 strings

        Console.ReadLine()
        0
