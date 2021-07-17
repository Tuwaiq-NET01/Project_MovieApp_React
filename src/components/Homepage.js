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
      axios.get("http://www.omdbapi.com/?s=tom%20and%20jerry&apikey=d4902665")
      .then((res)=>{
          setmovie(res.data.Search)
      }).catch((err) => {
              console.log("error", err);
          })
      }

   
    const movieList = movie.map((item, index) => {
        return <MovieCards key={index}  Poster =  {<img src = {item.Poster} />}  Title ={item.Title} Year={item.Year} imdbID={"imdb ID: "+item.imdbID} Type={item.Type} />
    })
    const movieRow = movieList.map((item) => {
        return <Col xs ="3">{item} </Col>
    })



    return (
        <div>
            <center><img className="Header" src = "https://duetaz.org/wp-content/uploads/2018/07/Movie-Night.jpg" /></center>
              <center><div className = "space"> </div>
     

</center>    

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
