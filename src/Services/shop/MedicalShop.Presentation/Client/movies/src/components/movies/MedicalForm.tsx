import {NavLink, useNavigate, useParams } from "react-router-dom";
import {MedicalDto} from "../../models/MedicalDto.ts";
import {ChangeEvent, useEffect, useState } from "react";
import apiConnector from "../../api/apiConnector.ts";
import {Button, Form, Segment } from "semantic-ui-react";

export default function MedicalForm() {
    
    const {id} = useParams();
    const navigate = useNavigate();
    
    const [Medical, setMedical] = useState<MedicalDto>({
       id: undefined,
       title: '',
       description: '',
       createDate: undefined,
       category: '' 
    });

    useEffect(() => {
        if (id) {
            apiConnector.getMedicalById(id).then(Medical => setMedical(Medical!))
        }
    }, [id]);
    
    function handleSubmit() {
        if (!Medical.id){
            apiConnector.createMedical(Medical).then(() => navigate('/'));
        } else {
            apiConnector.editMedical(Medical).then(() => navigate('/'));
        }
    }
    
    function handleInputChange(event: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>){
        const {name, value} = event.target;
        setMedical({...Medical, [name]: value});
    }
    
    return (
        <Segment clearing inverted>
            <Form onSubmit={handleSubmit} autoComplete='off' className='ui invereted form'>
                <Form.Input placeholder='Title' name='title' value={Medical.title} onChange={handleInputChange}/>
                <Form.TextArea placeholder='Description' name='description' value={Medical.description} onChange={handleInputChange}/>
                <Form.Input placeholder='Category' name='category' value={Medical.category} onChange={handleInputChange}/>
                <Button floated='right' positive type='submit' content='Submit'/>
                <Button as={NavLink} to='/' floated='right' type='button' content='Cancel'/>
            </Form> 
        </Segment>
    )
}