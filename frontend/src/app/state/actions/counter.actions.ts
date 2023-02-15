import { createActionGroup, emptyProps, props } from "@ngrx/store";


export const counterEvents = createActionGroup({
    source: 'Counter Events',
    events: {
        'Count Incremented': emptyProps(),
        'Count Decremented': emptyProps(),
        'Count Reset': emptyProps(),
        "Count By Set": props<{ by: number }>()
    }
})