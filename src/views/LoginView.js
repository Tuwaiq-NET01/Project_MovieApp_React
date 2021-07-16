import React, { useState } from "react"
import { useDispatch } from "react-redux"
import { login } from "../actions"
import { useHistory } from "react-router-dom"
import { Container, Button, Row, Col, Form, Spinner } from "react-bootstrap"

export default function LoginScreen() {
  const history = useHistory()
  const dispatch = useDispatch()
  const [name, setName] = useState(() => "Pooie")
  const [email, setEmail] = useState(() => "hello@mofie.sa")
  const [password, setPassword] = useState(() => "Pass1325!")
  const [loading, setLoading] = useState(() => false)

  const user = JSON.parse(localStorage.getItem("user"))
  if (user) {
    history.push("/")
  }

  const signin = () => {
    setLoading(true)
    setTimeout(() => {
      dispatch(login({ name: name, email: email }))
      history.push("/")
    }, 1000)
  }
  return (
    <Container fluid>
      <Row className="pt-3">
        <Col />
        <Col lg="4" className="pt-5">
          {loading ? (
            <div className="text-center mt-5 pt-5">
              <Spinner animation="grow" size="lg" />
            </div>
          ) : (
            <div>
              <h2 className="text-center pb-3" style={{ color: "#FFA726" }}>
                Login to Mofie
              </h2>
              <Form>
                <Form.Group>
                  <Form.Label>Name</Form.Label>
                  <Form.Control
                    type="email"
                    value={name}
                    onChange={(e) => setName(e.target.value)}
                    onFocus={() => setName("")}
                  />
                  <Form.Text>May I know your name?</Form.Text>
                </Form.Group>
                <Form.Group>
                  <Form.Label>Email</Form.Label>
                  <Form.Control
                    type="email"
                    value={email}
                    onChange={(e) => setEmail(e.target.value)}
                  />
                </Form.Group>

                <Form.Group>
                  <Form.Label>Password</Form.Label>
                  <Form.Control
                    type="password"
                    value={password}
                    onChange={(e) => setPassword(e.target.value)}
                  />
                </Form.Group>

                <Button
                  className="w-100 bg-accent mb-3"
                  onClick={() => signin()}
                >
                  Login
                </Button>
              </Form>
            </div>
          )}
        </Col>
        <Col />
      </Row>
    </Container>
  )
}
