import React, { useEffect, useState } from "react";
import Lottie from "react-lottie";
import * as location from "./1055-world-locations.json";
import MovieResults from "./components/MovieResults";
import Search from "./components/Search";
const defaultOptions1 = {
  loop: true,
  autoplay: true,
  animationData: location.default,
  rendererSettings: {
    preserveAspectRatio: "xMidYMid slice",
  },
};
function PreLoader1() {
  const [data, setData] = useState([]);
  const [loading, setloading] = useState(undefined);
  const [completed, setcompleted] = useState(undefined);
  useEffect(() => {
    setTimeout(() => {
      fetch("https://jsonplaceholder.typicode.com/posts")
        .then((response) => response.json())
        .then((json) => {
          console.log(json);
          setData(json);
          setloading(true);
          setTimeout(() => {
            setcompleted(true);
          }, 1000);
        });
    }, 2000);
  }, []);
  return (
    <>
          {!loading ? (
            <Lottie options={defaultOptions1} height={200} width={200} />
          ) :( 
            <Search/>
          )}
        </>
  );
}
export default PreLoader1;