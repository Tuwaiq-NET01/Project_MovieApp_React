import React, { useState, useEffect } from "react"
import { Container, Row, Col, Badge, Card, Button } from "react-bootstrap"
import { useHistory } from "react-router"
import { Link } from "react-router-dom"
import axios from "axios"

export default function HomeView() {
  const user = JSON.parse(localStorage.getItem("user"))
  const history = useHistory()
  if (!user) history.push("/login")

  const [latest, setLatest] = useState(() => [])

  useEffect(() => {
    axios(
      "https://api.themoviedb.org/3/discover/movie?api_key=d7779d14a18e6ed420e482a36129e67b&language=en-US&sort_by=release_date.desc&include_adult=false&include_video=false&primary_release_year=2021&with_watch_monetization_types=flatrate"
    ).then((res) => {
      if (res.status === 200) {
        setLatest(res.data.results)
      }
    })
  }, [])
  return (
    <Container fluid="md">
      <Row>
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
          <h1 style={{ color: "#FFA726", margin: "20px" }}>
            TMDB Movies <Badge style={{ background: "black" }}>Latest 20</Badge>
          </h1>
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
                      margin: "20px",
                      width: "20rem",
                    }}
                  >
                    <Card.Img
                      variant="top"
                      src={
                        movie.poster_path
                          ? `https://image.tmdb.org/t/p/w500/${movie.poster_path}`
                          : "https://sd.keepcalms.com/i/keep-calm-poster-not-found.png"
                      }
                      height={500}
                    />
                    <Card.Body>
                      <Card.Title style={{ color: "#FFA726" }}>
                        {movie.title.substring(0, 20)}
                      </Card.Title>
                      <Card.Text>
                        {movie.release_date + " " + movie.original_language}
                      </Card.Text>
                      <Card.Text>
                        {movie.overview.substring(0, 50) + "..."}
                      </Card.Text>
                    </Card.Body>
                    <Link
                      to={`/movie/${movie.id}`}
                      className="btn"
                      style={{
                        background: "#FFA726",
                        borderWidth: "0px",
                        margin: "20px",
                        marginBottom: "10px",
                      }}
                    >
                      Learn More
                    </Link>
                    <Button
                      style={{
                        background: "black",
                        color: "#ffa726",
                        borderWidth: "0px",
                        margin: "20px",
                        marginTop: "0px",
                      }}
                      href={`https://www.themoviedb.org/movie/${movie.id}`}
                      target="_blank"
                      rel="noopener noreferrer"
                    >
                      TMDB
                    </Button>
                  </Card>
                )
              })}
          </div>
        </Col>
      </Row>
      <div style={{ textAlign: "center", padding: "20px" }}>
        <p>2021 © Mofie</p>
      </div>
    </Container>
  )
}
