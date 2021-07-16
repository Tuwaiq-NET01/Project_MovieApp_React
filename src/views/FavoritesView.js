import React from "react";
import { useSelector, useDispatch } from "react-redux";
import { Container, Row, Col, Badge, Card, Button } from "react-bootstrap";
import { Link } from "react-router-dom";
import { DeleteFav } from "../actions";
export default function FavoritesView() {
  const favorites = useSelector((state) => state.favorite);
  const dispatch = useDispatch();

  const unFavorite = (movie) => {
    dispatch(DeleteFav(movie));
  };
  return (
    <Container>
      {favorites.length > 0 ? (
        <div
          style={{
            display: "flex",
            flexWrap: "wrap",
            justifyContent: "center",
            alignItems: "center",
          }}
        >
          {favorites.map((movie, index) => {
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
                <Button
                  style={{
                    background: "#FFA726",
                    borderWidth: "0px",
                    margin: "20px",
                    marginTop: "0px",
                  }}
                  onClick={() => unFavorite(movie)}
                >
                  Unfavorite
                </Button>
              </Card>
            );
          })}
        </div>
      ) : (
        <Row>
          <Col style={{ textAlign: "center", margin: "30px" }}>
            You have no favorites 💩.
          </Col>
        </Row>
      )}
    </Container>
  );
}
