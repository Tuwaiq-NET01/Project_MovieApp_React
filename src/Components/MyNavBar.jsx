import { Navbar, Nav } from 'react-bootstrap'
import { Link } from "react-router-dom";
import React, { useState, useContext }  from 'react';
import { GoogleLogin, GoogleLogout } from 'react-google-login';
import { useTranslation, Trans } from 'react-i18next'
import ThemeContext from "./ThemeContext"
import ThemeSwitcher from "./ThemeSwitcher"
const langs = {
  en: "English",
  ar: "Arabic"
}


const MyNavBar = () => {
  const [login, setLogin] = useState(false);
  const [profileObj, setProfileObj] = useState({});
  const { i18n } = useTranslation()
  const { theme } = useContext(ThemeContext)
  
  const onSuccess = (res) => {
    console.log('Login Success: currentUser:', res.profileObj);
    alert(
      `Logged in successfully welcome ${res.profileObj.name} 😍.`
    );
    setProfileObj(res.profileObj)
    setLogin(true)
  };

  const onFailure = (res) => {
    console.log('Login failed: res:', res);
    alert(
      `Failed to login. 😢`
    );
  };

  const onSuccessLogout = () => {
    console.log('Logout made successfully');
    alert('Logout made successfully ✌');
    setLogin(false)
  };

  return (
    <Navbar className={theme} collapseOnSelect expand="lg" variant="light" >
      <Navbar.Brand as={Link} to="/" >
        <img alt="logo" width="150" src="https://d33wubrfki0l68.cloudfront.net/c6a54be7d89b1ebc31ad2f5558ee470fd4ebd11e/1fb54/institute-images/logo-text-black-centered.png"></img>
      </Navbar.Brand>
      <Navbar.Toggle aria-controls="responsive-navbar-nav" />
      <Navbar.Collapse id="responsive-navbar-nav">
        <Nav className="mr-auto">
          <Nav.Link as={Link} to="/">
          {<Trans i18nKey="home">Home</Trans>}
        </Nav.Link>
          <Nav.Link as={Link} to="/browse">
          {<Trans i18nKey="browse">Browse</Trans>}
        </Nav.Link>
          <Nav.Link as={Link} to="/about">
          {<Trans i18nKey="about">About</Trans>}
        </Nav.Link>
        <ThemeSwitcher/>
        </Nav>
        {Object.keys(langs).map((lang) => (
        <button
          style={{ fontWeight: i18n.language === lang ? "bold" : "normal" ,marginRight:"14px"}}
          onClick={() => i18n.changeLanguage(lang)}
        >{langs[lang]}
        </button>
        
      ))}
        {!login ? (<GoogleLogin
          clientId="527075466581-u0krqedrqk3kpvg89569p832g7gi7per.apps.googleusercontent.com"
          buttonText={<Trans i18nKey="login">Login</Trans>}
          onSuccess={onSuccess}
          onFailure={onFailure}
          cookiePolicy={'single_host_origin'}
          style={{ marginTop: '100px' }}
          isSignedIn={true}
        />) :

        (<div>
          <span className="mr-3"> {<Trans i18nKey="welcome">Welcome</Trans>} {profileObj.name} </span>
          <GoogleLogout
            clientId="527075466581-u0krqedrqk3kpvg89569p832g7gi7per.apps.googleusercontent.com"
            buttonText= {<Trans i18nKey="logout">Logout</Trans>}
            onLogoutSuccess={onSuccessLogout}
          ></GoogleLogout>
        </div>)
        }
      </Navbar.Collapse>
    </Navbar>
  );
}

export default MyNavBar;
