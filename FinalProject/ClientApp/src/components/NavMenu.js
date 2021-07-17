import React, { Component, useState } from "react";
import {
    Collapse,
    Container,
    Nav,
    Navbar,
    NavbarBrand,
    NavbarToggler,
    NavItem,
    NavLink,
} from "reactstrap";
import { Link } from "react-router-dom";

import logo from "./logo.png"

import "./NavMenu.css";
import axios from "axios";

import { useTranslation, Trans } from 'react-i18next'
const langs = {
  en: "English",
  ar: "Arabic"
}

function NavMenu(props) {
    const [collapsed, setCollapsed] = useState(true);
    const { i18n } = useTranslation()

    let logMenu;
    let favMenu;

    const logout = () => {
        axios
            .post(
                "https://localhost:5001/api/auth/logout",
                {},
                {
                    withCredentials: true,
                }
            )
            .then((res) => {
                console.log(res);
                props.setUser({});
            })
            .catch((err) => console.log(err));
    };

    const toggleNavbar = () => {
        setCollapsed(!collapsed);
    };

    // console.log(props.user)
    if (Object.keys(props.user).length < 1) {
        logMenu = (
            <ul className="navbar-nav flex-grow">
                <NavItem>
                    <NavLink tag={Link} className="text-light btn mySearchBtn" to="/login">
                        <i className="fas fa-sign-in-alt fa-2x"></i>
                    </NavLink>
                </NavItem>
            </ul>
        );

        favMenu = null;
    } else {
        logMenu = (
            <ul className="navbar-nav flex-grow">
                <NavItem>
                    <NavLink
                        tag={Link}
                        className="text-light btn mySearchBtn"
                        to="/profile"
                    >
                        <i className="fas fa-user-circle fa-2x"></i>
                    </NavLink>
                </NavItem>
                <NavItem>
                    <NavLink
                        tag={Link}
                        className="text-light btn mySearchBtn"
                        to="/"
                        onClick={logout}
                    >
                        <i className="fas fa-sign-out-alt fa-2x"></i>
                    </NavLink>
                </NavItem>
            </ul>
        );

        favMenu = (
            <div style={{ display: "flex", float: "left" }}>
                <NavItem>
                    <NavLink
                        tag={Link}
                        className="text-light"
                        to="/favorite-movies"
                    >
                        Favorite Movies
                    </NavLink>
                </NavItem>
                <NavItem>
                    <NavLink tag={Link} className="text-light" to="/favorite-tvshow">
                        Favorite TV Shows
                    </NavLink>
                </NavItem>
            </div>
        );
    }

    return (
        <header className="fade-me">
            <Navbar
                className="navbar-expand-sm navbar-toggleable-sm ng-white  border-bottom box-shadow mb-3"
                light
            >
                <Container>
                    <NavbarBrand tag={Link} to="/">
                        <img src={logo} alt="not" height="50px"/>
                    </NavbarBrand>
                    <NavbarToggler onClick={toggleNavbar} className="mr-2" />
                    <Collapse
                        className="d-sm-inline-flex flex-sm-row-reverse"
                        isOpen={!collapsed}
                        navbar
                    >
                        {logMenu}
                        <ul className="navbar-nav flex-grow">
                <NavItem>
                   
                       {Object.keys(langs).map((lang) => (
                    <button
                    style={{ fontWeight: i18n.language === lang ? "bold" : "normal" }}
                    className="text-light btn mySearchBtn"
                    onClick={() => i18n.changeLanguage(lang)}
                    >{langs[lang]}
                    </button>
                ))}
                </NavItem>
            </ul>
                        <Nav className="mr-auto" navbar>
                            <NavItem>
                                <NavLink
                                    tag={Link}
                                    className="text-light"
                                    to="/"
                                >
                                    <Trans i18nKey="Home">
                                        Home
                                    </Trans>

                                </NavLink>
                            </NavItem>
                            <NavItem>
                                <NavLink
                                    tag={Link}
                                    className="text-light"
                                    to="/movies"
                                >
                                    <Trans i18nKey="Movies">
                                    Movies
                                    </Trans>
                                </NavLink>
                            </NavItem>
                            <NavItem>
                                <NavLink
                                    tag={Link}
                                    className="text-light"
                                    to="/tv-shows"
                                >
                                    <Trans i18nKey="Tv Shows">
                                        TV Shows
                                    </Trans>
                                </NavLink>
                            </NavItem>
                            {favMenu}
                        </Nav>
                    </Collapse>
                </Container>
            </Navbar>
        </header>
    );
}

export default NavMenu;
