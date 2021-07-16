import React, { useEffect, useState } from "react";
import { useDispatch } from "react-redux";
import { useHistory, useParams } from "react-router-dom";
import { Container, Row, Col, ListGroup, Button } from "react-bootstrap";
import axios from "axios";
import { AddFav } from "../actions";
export default function MovieView() {
  const history = useHistory();
  const user = JSON.parse(localStorage.getItem("user"));
  if (!user) history.push("/login");
  const { id } = useParams();
  const [movie, setMovie] = useState(() => {});

  useEffect(() => {
    axios(
      `https://api.themoviedb.org/3/movie/${id}?api_key=d7779d14a18e6ed420e482a36129e67b&language=en-US`
    ).then((res) => {
      setMovie(res.data);
    });
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);

  const dispatch = useDispatch();

  const addToFavorite = () => {
    dispatch(AddFav(movie));
    console.log(movie);
  };
  return (
    <Container fluid="md">
      <Row>
        <Col
          lg={6}
          style={{
            margin: "30px",
          }}
        >
          <img
            alt="Poster"
            src={
              movie && movie.poster_path
                ? `https://image.tmdb.org/t/p/w500/${movie.poster_path}`
                : "https://sd.keepcalms.com/i/keep-calm-poster-not-found.png"
            }
            width={"100%"}
            height={550}
          />{" "}
          <Button
            style={{
              background: "#FFA726",
              marginTop: "20px",
              width: "100%",
              borderColor: "#FFA726",
            }}
            onClick={() => addToFavorite()}
          >
            Add to Favorites
          </Button>
        </Col>
        <Col>
          <Row>
            <ListGroup style={{ margin: "30px", width: "100%" }}>
              <ListGroup.Item>
                Title ➜{" "}
                <span style={{ color: "#FFA726" }}>{movie && movie.title}</span>
              </ListGroup.Item>
              <ListGroup.Item>
                Tagline ➜{" "}
                <span style={{ color: "#FFA726" }}>
                  {movie && movie.tagline}
                </span>
              </ListGroup.Item>
              <ListGroup.Item>
                Status ➜{" "}
                <span style={{ color: "#FFA726" }}>
                  {movie && movie.status}
                </span>
              </ListGroup.Item>
              <ListGroup.Item>
                Release ➜{" "}
                <span style={{ color: "#FFA726" }}>
                  {movie && movie.release_date}
                </span>
              </ListGroup.Item>
              <ListGroup.Item>
                Overview ➜{" "}
                <span style={{ color: "#FFA726" }}>
                  {movie && movie.overview}
                </span>
              </ListGroup.Item>
              <ListGroup.Item>
                Runtime ➜{" "}
                <span style={{ color: "#FFA726" }}>
                  {" "}
                  {movie && movie.runtime} mintues
                </span>
              </ListGroup.Item>
              <ListGroup.Item>
                Adult ➜{" "}
                <span style={{ color: "#FFA726" }}>
                  {movie && movie.adult.toString()}
                </span>
              </ListGroup.Item>
              <ListGroup.Item>
                Budget ➜{" "}
                <span style={{ color: "#FFA726" }}>
                  ${movie && movie.budget}
                </span>
              </ListGroup.Item>
              <ListGroup.Item>
                Revenue ➜{" "}
                <span style={{ color: "#FFA726" }}>
                  ${movie && movie.revenue}
                </span>
              </ListGroup.Item>
              <ListGroup.Item>
                Popularity ➜{" "}
                <span style={{ color: "#FFA726" }}>
                  {movie && movie.popularity}
                </span>
              </ListGroup.Item>
              <ListGroup.Item>
                Vote Count ➜{" "}
                <span style={{ color: "#FFA726" }}>
                  {movie && movie.vote_count}
                </span>
              </ListGroup.Item>
              <ListGroup.Item>
                Vote Average ➜{" "}
                <span style={{ color: "#FFA726" }}>
                  {movie && movie.vote_average}
                </span>
              </ListGroup.Item>
            </ListGroup>
          </Row>
        </Col>
      </Row>
    </Container>
  );
}
