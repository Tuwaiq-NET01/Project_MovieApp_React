import React, { useState, useEffect} from "react"
import { Container, Row, Col, Card, Button } from "react-bootstrap"
import { save } from '../actions'
import {useDispatch} from "react-redux";
import axios from "axios"

export default function HomeView() {
const dispatch = useDispatch()
  const [latest, setLatest] = useState(() => [])
    const [keywords, setKeywords] = useState(() => "lion king")

    const search = () => {
        axios(
            `https://api.themoviedb.org/3/search/movie?api_key=d7779d14a18e6ed420e482a36129e67b&language=en-US&query=${
                keywords.length > 1 ? keywords : "titanic"
            }&page=1`
        )
            .then((res) => {
                setLatest(res.data.results)
            })
            .catch((e) => {
                console.log(e.message)
            })
    }

    useEffect(() => {
    axios(
      "https://api.themoviedb.org/3/discover/movie?api_key=d7779d14a18e6ed420e482a36129e67b&language=en-US&sort_by=release_date.desc&include_adult=false&include_video=false&primary_release_year=2021&with_watch_monetization_types=flatrate"
    ).then((res) => {
      if (res.status === 200) {
          dispatch(save(res.data.results))
        setLatest(res.data.results)
      }
    })
  }, [])
  return (
    <Container fluid="md">
        <Row style={{display: 'flex', justifyContent: 'center'}}>
      <input
          style={{
            width: "80%",
            borderWidth: 2,
              marginTop: '20px',
            borderColor: "red",
            borderStyle: "double",
            borderRadius: "5px",
            padding: "10px",
          }}
          placeholder="Search a movie..."
          type="text"
          value={keywords}
          onChange={(e) => {
            setKeywords(e.target.value)
            search()
          }}
      />
            <Col
                lg={12}
                style={{
                    display: "flex",
                    flexDirection: "column",
                    justifyContent: "center",
                    alignItems: "center",
                    textAlign: "center",
                }}
            >
                <div
                    style={{
                        display: "flex",
                        flexWrap: "wrap",
                        justifyContent: "center",
                        alignItems: "center",
                    }}
                >
                    {latest &&
                    latest.map((movie, index) => {
                        return (
                            <Card
                                key={index}
                                style={{
                                    margin: "5px",
                                    width: "15rem",
                                }}
                            >
                                <Card.Img
                                    variant="top"
                                    src={
                                        movie.poster_path
                                            ? `https://image.tmdb.org/t/p/w500/${movie.poster_path}`
                                            : "https://sd.keepcalms.com/i/keep-calm-poster-not-found.png"
                                    }
                                    height={300}
                                />
                                <Card.Body>
                                    <Card.Title style={{ color: "red" }}>
                                        {movie.title.substring(0, 20)}
                                    </Card.Title>
                                    <Card.Text>
                                        {movie.release_date + " " + movie.original_language}
                                    </Card.Text>
                                    <Card.Text>
                                        {movie.overview.substring(0, 47) + "..."}
                                    </Card.Text>
                                    <Card.Text>
                                        pupularity:{movie.popularity}
                                    </Card.Text>
                                </Card.Body>
                                <Button
                                    style={{
                                        background: "black",
                                        color: "red",
                                        borderWidth: "0px",
                                        margin: "20px",
                                        marginTop: "0px",
                                    }}
                                    href={`https://www.themoviedb.org/movie/${movie.id}`}
                                    target="_blank"
                                    rel="noopener noreferrer"
                                >
                                    More Info
                                </Button>
                            </Card>
                        )
                    })}
                </div>
            </Col>
        </Row>
    </Container>
  )
}
