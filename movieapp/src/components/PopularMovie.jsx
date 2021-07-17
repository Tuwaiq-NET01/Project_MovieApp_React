import React from 'react'
import { useState, useEffect } from "react";
import { Col, Container, Form, Row } from 'react-bootstrap'

import axios from 'axios';
import OnecardPopularMovie from './OnecardPopularMovie';
export default function PopularMovie() {
    const [allPopularmovies, setallPopularmovies] = useState([])
    
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
    return (
       <Container>
         <Row className="justify-content-md-center">
           {allPopularM}
         </Row>
         </Container>
    )
}
