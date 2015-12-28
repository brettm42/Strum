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
        let Ebm7 = chord Eb m7 strings
        let ``D#m7`` = chord ``D#`` m7 strings
        let Dm7 = chord D m7 strings
        let FM7 = chord F M7 strings
        let ``G#M9`` = chord ``G#`` M9 strings
        let Am9 = chord A m9 strings
        let ``C#13`` = chord ``C#`` ``13`` strings

        printfn "C major"
        printTab CM strings

        printfn "\r\nC minor"
        printTab Cm strings

        printfn "\r\nD minor 7th"
        printTab Dm7 strings

        printfn "\r\nF major 7th"
        printTab FM7 strings

        printfn "\r\nG# major 9th"
        printTab ``G#M9`` strings

        printfn "\r\nA minor 9th"
        printTab Am9 strings

        printfn "\r\nC#13"
        printTab ``C#13`` strings

        printfn "\r\nEb minor 7th"
        printTab Ebm7 strings

        printfn "\r\nD# minor 7th"
        printTab ``D#m7`` strings

        Console.ReadLine()
        0