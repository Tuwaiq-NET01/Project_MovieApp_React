import React, { useState, useEffect } from 'react'
import axios from 'axios'
import { useSelector, useDispatch } from 'react-redux'
import { login, logout } from '../actions'
import { useHistory } from 'react-router-dom'
import {
  Container,
  Button,
  Row,
  Col,
  Form,
  Spinner,
  Alert,
} from 'react-bootstrap'

export default function LoginScreen() {
  const history = useHistory()
  const dispatch = useDispatch()
  const [name, setName] = useState(() => 'Pooie')
  const [email, setEmail] = useState(() => 'hello@mofie.sa')
  const [password, setPassword] = useState(() => 'Pass1325!')
  const [image, setImage] = useState(() => '')
  const [loginForm, setLoginForm] = useState(() => true)
  const [loading, setLoading] = useState(() => false)
  const [alert, setAlert] = useState(() => 'none')

  const signin = () => {
    setLoading(true)
    setAlert(true)
    setTimeout(() => {
      dispatch(login({ name: name, email: email }))
      history.push('/')
    }, 1000)
  }
  return (
    <Container fluid>
      <Row className="pt-3">
        <Col />
        <Col lg="4" className="pt-5">
          {loading ? (
            <div className="text-center mt-5">
              <Spinner animation="grow" variant="primary" size="lg" />
            </div>
          ) : (
            <div>
              <h2 className="text-center text-light pb-3">Login to Mofie™</h2>
              <Alert style={{ display: alert }} variant="danger">
                Something is not right{' '}
                <span role="img" aria-label="">
                  💩.
                </span>
              </Alert>
              <Form>
                <Form.Group>
                  <Form.Label className="text-light">Name</Form.Label>
                  <Form.Control
                    type="email"
                    value={name}
                    onChange={(e) => setName(e.target.value)}
                  />
                  <Form.Text>May I know your name?</Form.Text>
                </Form.Group>
                <Form.Group>
                  <Form.Label className="text-light">Email</Form.Label>
                  <Form.Control
                    type="email"
                    value={email}
                    onChange={(e) => setEmail(e.target.value)}
                  />
                </Form.Group>

                <Form.Group>
                  <Form.Label className="text-light">Password</Form.Label>
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
