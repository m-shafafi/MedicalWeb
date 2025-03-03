import { Link } from "react-router";

function Home() {
  return <>home
  <br/>
  <Link to={"/test"}>go to test page</Link>
  </>;
}

export default Home;
