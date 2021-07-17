import React from "react"
import { Navbar } from "react-bootstrap"
import { Link } from "react-router-dom"
export default function NavBar() {

  return (
    <Navbar style={{background:"red", display:'flex', justifyContent:'center'}}>
      <Navbar.Brand>
        <Link style={{color:"black"}} to="/">
          TMOVIE
        </Link>
      </Navbar.Brand>


    </Navbar>
  )
}
