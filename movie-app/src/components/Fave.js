import React from 'react';
import add from '../add.png';
import remove from '../remove.png';

function Fave(props){

   const handleFaveClick = (e) => {
        e.stopPropagation()

        props.onFaveToggle()
    }
    const message = props.isFave ? <img className="addremove" src={remove} alt="remove" /> : <img className="addremove" src={add} alt="add" />

    return ( 
        <div  onClick={handleFaveClick} >
            <p className="material-icons">{message}</p>
        </div>
    );
    
}
 
export default Fave;