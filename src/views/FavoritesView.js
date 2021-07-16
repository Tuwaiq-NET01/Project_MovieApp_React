import React from "react"
import { Container, Row, Col } from "react-bootstrap"

export default function FavoritesView() {
  return (
    <Container>
      <Row>
        <Col style={{ textAlign: "center", margin: "30px" }}>
          You have no favorites 💩.
        </Col>
      </Row>
    </Container>
  )
}
