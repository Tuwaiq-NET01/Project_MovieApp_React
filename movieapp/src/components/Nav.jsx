import React from 'react'
import { Button, Card, Col, Row,Navbar,Container,Nav } from 'react-bootstrap'
import { BrowserRouter as Router, Link, Route } from "react-router-dom";



export default function Nav1() {
    return (
        <div>
               <Navbar bg="light" expand="lg">
                <Container>
                    <Navbar.Brand ><Nav.Link as={Link} to="/">Home</Nav.Link></Navbar.Brand>

                    <Navbar.Toggle aria-controls="basic-navbar-nav" />
                    <Navbar.Collapse id="basic-navbar-nav">
                        <Nav className="me-auto">
                            <Nav.Link as={Link} to="/popular">Popular Movie</Nav.Link>
                            <Nav.Link as={Link} to="/search">Search </Nav.Link>
                        </Nav>
                    </Navbar.Collapse>
                </Container>
            </Navbar>
        </div>
    )
}
