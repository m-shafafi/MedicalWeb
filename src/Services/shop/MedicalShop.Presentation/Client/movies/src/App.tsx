import {Outlet, useLocation } from 'react-router-dom';
import './App.css'
import MedicalTable from "./components/Medicals/MedicalTable.tsx";
import { Container } from 'semantic-ui-react';

function App() {
    const location = useLocation();
    
  return (
    <>
        {location.pathname === '/' ? <MedicalTable /> : (
            <Container className="container-style">
                <Outlet />
            </Container>
        )}
    </>
  )
}

export default App
