namespace Strum

open System

[<Struct>]
[<CustomComparison>]
[<CustomEquality>]
[<StructuredFormatDisplay("{Display}")>]
type Note(note : int) =
    
    static member noteNames = 
        [| "C"; "C#"; "D"; "Eb"; "E"; "F"; "F#"; "G"; "Ab"; "A"; "Bb"; "B" |]

    member __.Note = note

    override __.Equals item =
        match item with 
        | :? Note as item ->
            note % 12 = item.Note % 12
        | _ -> false

    override __.GetHashCode() = note % 12

    member __.Display =
        let name = Note.noteNames.[note % 12]
        let octave = note / 12
        sprintf "%s %d" name octave

    override this.ToString() = this.Display

    interface IEquatable<Note> with
        member __.Equals item =
            note % 12 = item.Note % 12
            
    interface IComparable<Note> with
        member __.CompareTo item =
            compare (note % 12) (item.Note % 12)

    interface IComparable with
        member __.CompareTo item =
            match item with
            | :? Note as item ->
                compare (note % 12) (item.Note % 12)
            | _ -> 1

    static member (+) (string : Note, steps : int) =
        Note (string.Note + steps)

    member __.Sharpen steps =
        note = note + steps

    member __.Flatten steps =
        note = note - steps