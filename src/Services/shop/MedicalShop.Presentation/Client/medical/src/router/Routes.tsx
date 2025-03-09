import { RouteObject, createBrowserRouter } from "react-router-dom";
import App from "../App.tsx";
import MedicalForm from "../components/Medicals/MedicalForm.tsx";

export const routes: RouteObject[] = [
    {
        path: '/',
        element: <App/>,
        children: [
            {path: 'createMedical', element: <MedicalForm key='create' />},
            {path: 'editMedical/:id', element: <MedicalForm key='edit' />}
        ]
    }
]

export const router = createBrowserRouter(routes)