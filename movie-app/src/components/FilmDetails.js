import React from 'react';

function FilmDetails(props){

    const films = props.film
    console.log(props.film)
    const backdropUrl = `https://image.tmdb.org/t/p/w1280/${films.current.backdrop_path}`
    const posterUrl = `https://image.tmdb.org/t/p/w780/${films.current.poster_path}`
    let details;
   
    if(films.current.id){
       details =  <div className="film-detail is-hydrated">
                    <figure className="film-backdrop">
                        <img src={backdropUrl} alt="" />
                        <h1 className="film-title">{films.current.title}</h1>
                    </figure>
                    
                    <div className="film-meta">
                        <h2 className="film-tagline">{films.current.tagline}</h2>
                        <p className="film-detail-overview">
                            <img src={posterUrl} className="film-detail-poster" alt={films.current.title} />
                            {films.current.overview}
                        </p>
                    </div>
                 </div>
    }else{

        details =  <div className="film-detail">
                        <p>
                            <i className="material-icons">subscriptions</i>
                            <span>No film selected</span>
                        </p>
                    </div> 
    }
    return(
        <div className="film-details">
             <h1 className="section-title">DETAILS</h1>
             {details}
        </div>
    ); 
}

export default FilmDetails;




 