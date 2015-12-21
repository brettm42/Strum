namespace Strum

[<AutoOpen>]
module Fretboard =
    open System
        
    let fretboardSize = 15

    // TODO: configure chord complexity, chord span
    let findFrets chord (string : Note) = 
        [0..fretboardSize]
        |> List.filter (fun fret -> Set.contains (string + fret) chord)
        |> List.map (fun fret -> fret, string + fret)

    let rec filterChord chord missingNotes solution stringFrets =
        match stringFrets with
        | [] ->
            if Set.isEmpty missingNotes then
                Some (List.rev solution)
            else
                None
        | string::tail ->
            string
            |> List.filter 
                (fun (_, note) -> 
                    chord |> Set.contains note)
            |> List.choose 
                (fun (fret, note) -> 
                    filterChord chord (Set.remove note missingNotes) ((fret, note)::solution) tail)
            |> List.sortBy 
                (fun l -> 
                    List.sumBy (fun (fret, _) -> fret * fret) l)
            |> List.tryHead