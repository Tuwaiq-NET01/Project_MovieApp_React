import React from 'react'
import { useState, useEffect } from "react";
import { Col, Container, Form, Row } from 'react-bootstrap'
import OnecardPopularMovie from './OnecardPopularMovie';
import Axios from 'axios';

export default function SearchMoive() {
   const [searchformoive, setsearchformoive] = useState("")

   const [movies , setMovie11] = useState([])



   useEffect(() => {
    Axios.get(`https://api.themoviedb.org/3/search/movie?api_key=413d4ed20f2b90db905d14c9135b1883&query=${searchformoive}`)
    .then(res =>{   
        console.log(res.data.results)  
        setMovie11(res.data.results)
    
    })
}, [searchformoive])

const allsearchmoive = movies.map((item,i)=>{
    return <OnecardPopularMovie item={item}/>
})

const onChangeHandler = (e) =>{
    let value = e.target.value
    console.log(value)
    setsearchformoive(value)

}

    return (
        <div>
            <div style={{textAlign:'center', margin:"20px" }}>
            <input style={{width:"400px"}} type="text" onChange={onChangeHandler} placeholder="movies search" />
            </div>
           
            <Row>
            {allsearchmoive}
            </Row>
        </div>
    )
}
