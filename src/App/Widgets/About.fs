module Widgets.About

open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fulma
open Fable.Repl.Prelude

let view =
    Content.content [ ]
        [ str ("Provided by the")
          br []
          a [ Href "https://fsharp.org" ]
            [ Text.span [ Props [ Style [ TextDecoration "underline" ] ] ]
                [ str "  F# Software Foundation" ] ]          
          br [ ]
          br [ ]
          a [ Href "https://fable.io/repl" ]
            [ Text.span [ Modifiers [ Modifier.TextTransform TextTransform.Italic ]
                          Props [ Style [ TextDecoration "underline" ] ] ]
                [ str "Based on Fable 2 REPL" ] ]
          br [ ]
          str ("Version: " + Literals.VERSION)
          br [ ]
          a [ Href "https://github.com/fsharp/TryFSharp/issues/new" ]
            [ Text.span [ Modifiers [ Modifier.TextTransform TextTransform.Italic ]
                          Props [ Style [ TextDecoration "underline" ] ] ]
                [ str "Found a bug?" ] ] ]
