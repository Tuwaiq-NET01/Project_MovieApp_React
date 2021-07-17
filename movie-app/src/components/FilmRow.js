import React from 'react';
import FilmPoster from './FilmPoster';
import Fave from './Fave';

function FilmRow(props){

        const year = new Date(props.film.release_date);

        return ( 
            <div onClick={() => props.handleDetailsClick(props.film)} className="film-row">
                <FilmPoster poster={props.film.poster_path} />
                    <div className="film-summary">
                        <h1>{props.film.title}</h1>
                        <p>{year.getFullYear()}</p>
                        <Fave onFaveToggle={props.onFaveToggle} isFave={props.isFave}/>
                    </div>
             </div>
         );  
}
 
export default FilmRow;