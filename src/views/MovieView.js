import React, { useEffect, useState } from "react";
import { useDispatch } from "react-redux";
import { useHistory, useParams } from "react-router-dom";
import { Container, Row, Col, ListGroup, Button } from "react-bootstrap";
import axios from "axios";
import { AddFav } from "../actions";
import { Trans } from 'react-i18next'
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
            <Trans i18nKey="Add_to_favorite" />
          </Button>
        </Col>
        <Col>
          <Row>
            <ListGroup style={{ margin: "30px", width: "100%" }}>
              <ListGroup.Item>
              <Trans i18nKey="MovieTitle" /> ➜ {" "}
                <span style={{ color: "#FFA726" }}>{movie && movie.title}</span>
              </ListGroup.Item>
              <ListGroup.Item>
              <Trans i18nKey="Tagline" />  ➜ {" "}
                <span style={{ color: "#FFA726" }}>
                  {movie && movie.tagline}
                </span>
              </ListGroup.Item>
              <ListGroup.Item>
              <Trans i18nKey="Status" />  ➜ {" "}
                <span style={{ color: "#FFA726" }}>
                  {movie && movie.status}
                </span>
              </ListGroup.Item>
              <ListGroup.Item>
              <Trans i18nKey="Release" />  ➜ {" "}
                <span style={{ color: "#FFA726" }}>
                  {movie && movie.release_date}
                </span>
              </ListGroup.Item>
              <ListGroup.Item>
              <Trans i18nKey="Overview" />  ➜ {" "}
                <span style={{ color: "#FFA726" }}>
                  {movie && movie.overview}
                </span>
              </ListGroup.Item>
              <ListGroup.Item>
              <Trans i18nKey="Runtime" /> 
               ➜ {" "}
                <span style={{ color: "#FFA726" }}>
                  {" "}
                  {movie && movie.runtime} mintues
                </span>
              </ListGroup.Item>
              <ListGroup.Item>
              <Trans i18nKey="Adult" />  ➜ {" "}
                <span style={{ color: "#FFA726" }}>
                  {movie && movie.adult.toString()}
                </span>
              </ListGroup.Item>
              <ListGroup.Item>
              <Trans i18nKey="Budget" />  ➜ {" "}
                <span style={{ color: "#FFA726" }}>
                  ${movie && movie.budget}
                </span>
              </ListGroup.Item>
              <ListGroup.Item>
              <Trans i18nKey="Revenue" />  ➜ {" "}
                <span style={{ color: "#FFA726" }}>
                  ${movie && movie.revenue}
                </span>
              </ListGroup.Item>
              <ListGroup.Item>
              <Trans i18nKey="Popularity" />  ➜ {" "}
                <span style={{ color: "#FFA726" }}>
                  {movie && movie.popularity}
                </span>
              </ListGroup.Item>
              <ListGroup.Item>
              <Trans i18nKey="Vote_Count" />  ➜ {" "}
                <span style={{ color: "#FFA726" }}>
                  {movie && movie.vote_count}
                </span>
              </ListGroup.Item>
              <ListGroup.Item>
              <Trans i18nKey="Vote_Average" /> 
               ➜ {" "}
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
