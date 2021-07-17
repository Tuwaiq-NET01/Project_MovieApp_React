import { Col, Row } from 'react-bootstrap';
import Container from 'react-bootstrap/Container'
import axios from 'axios'
import React, { useState, useEffect } from 'react'
import MovieCards from './MovieCards';


export default function Search(props) {

    const [movies, setMovies] = useState([])

    useEffect(() => {
        axios.get(`https://api.themoviedb.org/3/search/movie?api_key=8662614f90f667110ba1c010f0da4d34&query=${props.target}`)
            .then(res => {
                setMovies(res.data.results)
            })
            .catch(err => {
                console.error(err); 
            })

    }, [props.target])


    const displayMovies = movies.map((item) => {
        return (
            <div className='col-3'>
    <MovieCards Title={item.title} Poster={item.backdrop_path}/>
            </div>
        )})
    
    
    return (
        <div className='container'>
            <h1 className='display-4'>Search Results for: {props.target}</h1>

            <div className='row'>
                {displayMovies}
            </div>

        </div>
    )
}
