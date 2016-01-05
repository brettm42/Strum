namespace Strum

[<AutoOpen>]
module Chords =
    open System
       
    let notes = List.map Note
    
    let intervals = notes >> Set.ofList

    // TODO: allow user to add/remove chord voicings dynamically
    let M n = intervals [n; n + 4; n + 7]
    let m n = intervals [n; n + 3; n + 7]
    let M7 n = intervals [n; n + 4; n + 7; n + 11]
    let m7 n = intervals [n; n + 3; n + 7; n + 11]
    let M9 n = intervals [n; n + 4; n + 7; n + 10; n + 14]
    let m9 n = intervals [n; n + 3; n + 7; n + 10; n + 14]
    let ``13`` n = intervals [n; n + 4; n + 7; n + 11; n + 16]
    let m13 n = intervals [n; n + 3; n + 7; n + 11; n + 16]
        
    let chord root intervals strings =
        let chord = intervals (root 4)
        strings
        |> List.map (findFrets chord)
        |> filterChord chord chord []
        |> Option.get