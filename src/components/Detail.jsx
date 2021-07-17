import React, { useState, useEffect } from 'react'
import axios from 'axios'
import { useParams } from 'react-router';

export default function Detail() {
const {id} = useParams()
    const [movie, setmovie] = useState({});
    const [genre, setgen] = useState("");


    useEffect(() => {
        getmovie()
        }, [])
    
      const getmovie= () =>{
          axios.get(`https://api.themoviedb.org/3/movie/${id}?api_key=8662614f90f667110ba1c010f0da4d34&language=en-US`)
          .then((res)=>{
               setmovie(res.data)
               setgen(res.data.genres[0].name)
              console.log(res.data)
          }).catch((err) => {
                  console.log("error", err);
              })
          }
    
       
    return (
        <div className='container'>
            <div className='row mt-5'>
                <div className='col-3'>
                {<img src = {"https://image.tmdb.org/t/p/w500"+movie.poster_path} />}
                </div>
                <div className='col-9'>
                    <h1></h1>
                    <h1>{movie.original_title}</h1>
                    <h4>Genres: {genre}</h4>
                    <p>{movie.overview}</p>
                </div>
            </div>
        </div>
    )
}
