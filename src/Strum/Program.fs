namespace Strum

module Console = 
    open System

    [<EntryPoint>]
    let main argv = 
        
        let notes = List.map Note

        let strings = notes [E 4; A 4; D 4; G 4; B 4; E 4;]

        let CM = chord C M strings
        let Cm = chord C m strings

        CM |> print

        0
