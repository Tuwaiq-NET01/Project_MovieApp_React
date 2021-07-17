import React from 'react'
import { useState, useEffect } from "react";
import { Col, Container, Form, Row ,Button,Card} from 'react-bootstrap'
import { useSelector, useDispatch } from 'react-redux'
import { addTofavorites,removeFromFavorites} from '../action';


import axios from 'axios';
import OnecardPopularMovie from './OnecardPopularMovie';
export default function PopularMovie() {
    const [allPopularmovies, setallPopularmovies] = useState([])
    const dispatch = useDispatch()

    useEffect(() => {
        axios.get("https://api.themoviedb.org/3/movie/popular?api_key=413d4ed20f2b90db905d14c9135b1883")
        .then(res => {
            console.log("res", res.data.results)
            setallPopularmovies(res.data.results)
        }).catch(err => {
             console.log(err) 
             
            })

    }, [])

    const allPopularM = allPopularmovies.map((item,i)=>{
        return <OnecardPopularMovie item={item}/>
    })

    const favoriteList = useSelector(state => state.favorites)
    console.log(favoriteList)
        const [movieListState, setMovieListState] = useState([]);
        useEffect(() => {
           setMovieListState(
                favoriteList
            )
        }, [favoriteList])
    
        function remove (movie,i){
            dispatch(removeFromFavorites(movie,i))
        }
 
    
    return (
       <Container>
           <h3>My favorite</h3>
           <Row>
           {
               movieListState.map((item,i)=>(
                 
                <Col md="4" sm="4" className="mt-3">
                <Card className ="card-movie">
                    <Card.Img variant="top" src={"https://image.tmdb.org/t/p/original" + item.poster_path} height ="300px" style={{    margin :"auto" , objectFit :"cover"}}  />
                    <Card.Body>
                        <Card.Title>{item.original_title}</Card.Title>
                        <Card.Text>
                            year : {item.release_date}
                            <br/>
                             {item.vote_average} / 10
                            <br/>
                          
                            <Button variant="outline-danger"onClick={() => remove(item,i)}>Remove From Favorite</Button>
                         </Card.Text>
                       
                    </Card.Body>
                </Card>
            </Col>
               )
               )
               
           }
           </Row>
         <hr/>
         <Row className="justify-content-md-center">
           {allPopularM}
         </Row>
         </Container>
    )
}
