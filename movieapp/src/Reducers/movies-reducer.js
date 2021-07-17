import {MOVIES} from '../Actions/index';

export default function movies(state = [], action)
{
    switch(action.type)
    {
        case MOVIES:
            console.log("Movies are ", action.items);
            return action.items;
            
        default:
            return state;
    }
}