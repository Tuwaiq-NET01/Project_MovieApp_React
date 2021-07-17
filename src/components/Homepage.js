import MovieCards from './MovieCards';
import React,{ useState,useEffect } from 'react';
import axios from 'axios'
import { Col, Row } from 'react-bootstrap';
import Container from 'react-bootstrap/Container'


export default function Homepage() {

    
  const [movie, setmovie] = useState([]);

  useEffect(() => {
    getmovie()
    }, [])

  const getmovie= () =>{
      axios.get("https://api.themoviedb.org/3/discover/movie?primary_release_year=2019&sort_by=vote_average.desc&api_key=8662614f90f667110ba1c010f0da4d34")
      .then((res)=>{
           setmovie(res.data.results)
           console.log(res.data.results)
      }).catch((err) => {
              console.log("error", err);
          })
      }

   
    const movieList = movie.map((item, index) => {
        return <MovieCards key={index}  Poster={item.poster_path} Title ={item.original_title} Year={item.release_date} imdbID={"imdb ID: "+item.id} Type={item.original_language} Movie={item} id={item.id}/>
    })
    const movieRow = movieList.map((item) => {
        return <Col className='mt-5' xs ="3">{item} </Col>
    })



    return (
        <div>
            <center><img className="Header" src = "https://duetaz.org/wp-content/uploads/2018/07/Movie-Night.jpg" /></center>
             

            <Container>

                <Col>
                    <Row>
                        {movieRow}
                    </Row>
                </Col>
            </Container>
        </div>
    )
}
