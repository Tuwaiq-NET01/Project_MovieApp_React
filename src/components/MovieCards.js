import React, { Component } from 'react'
import Card from 'react-bootstrap/Card'
import Button from 'react-bootstrap/Button'

export default function MovieCards (props)
{         return (
            
         <div className="Movie" >
             <center>
            <Card style={{ width: '16rem' }}>
            <center>{props.Poster} </center>
            <Card.Body>
            <Card.Title>{props.Title}</Card.Title>
            <Card.Text>{props.Year}  </Card.Text>
            <Card.Text>{props.imdbID}  </Card.Text>
            <Card.Text>{props.Type}  </Card.Text>
            <Button variant="danger">Book movie</Button>{' '}
            <div className="space1"></div>
            <Button variant="danger">Delete movie</Button>{' '}


            </Card.Body>
            </Card>
            </center>
         </div>
        )
    }
