import React from 'react'
import { useSelector, useDispatch } from 'react-redux'
import { removeFavorite } from '../action';
import MovieCards from './MovieCards';

export default function Favorite() {

    const favoriteList = useSelector(state => state.favoriteList)
    const dispatch = useDispatch()
    
    const displayFavs = favoriteList.map((item, index) => {
        return (
            <div className='col-3 mt-5'>

                <MovieCards 
                key={index}
                Poster={item.poster_path}
                Title={item.original_title}
                Year={item.release_date}
                imdbID={"imdb ID: " + item.id}
                Type={item.original_language}
                Movie={item}
                id={item.id}
                index={index}
                favMode={true}
                />


                {/* <button className='btn btn-danger' onClick={() => dispatch(removeFavorite(index))}>Unfavorite</button> */}
            </div>
        )
    })

    return (
        <div className='container'>
            <h1 className='display-4'>FAVORITES PAGE </h1>
            
            <div className="row">
                {displayFavs}
            </div>
                    
        </div>
    )
}
