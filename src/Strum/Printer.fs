namespace Strum

[<AutoOpen>]
module Printer =
    open System
        
    let printTab chord strings =
        let numStrings = (strings : Note list).Length
        let fretSpan = 5

        let fret1 n fret2 =
            if n = fret2 then "o"
            else "|"

        let line chord n =
            chord
            |> List.map (fst >> fret1 n)
            |> String.concat ""

        let stringTee = String.replicate numStrings "┬"
        let stringCross = String.replicate numStrings "┼"

        printfn "%s" stringTee
        [1 .. fretSpan]
        |> List.map (line chord)
        |> String.concat ("\r\n" + stringCross + "\r\n")
        |> printfn "%s"
