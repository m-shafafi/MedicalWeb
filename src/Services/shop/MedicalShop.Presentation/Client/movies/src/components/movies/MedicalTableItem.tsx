import { Button } from "semantic-ui-react";
import {MedicalDto} from "../../models/MedicalDto.ts";
import apiConnector from "../../api/apiConnector.ts";
import { NavLink } from "react-router-dom";

interface Props {
    Medical: MedicalDto;
}

export default function MedicalTableItem({Medical}: Props) {
    return (
        <>
            <tr className="center aligned">
                <td data-label="Id">{Medical.id}</td>
                <td data-label="Title">{Medical.title}</td>
                <td data-label="Description">{Medical.description}</td>
                <td data-label="CreateDate">{Medical.createDate}</td>
                <td data-label="Category">{Medical.category}</td>
                <td data-label="Action">
                    <Button as={NavLink} to={`editMedical/${Medical.id}`} color="yellow" type="submit">
                        Edit
                    </Button>
                    <Button type="button" negative onClick={async () => {
                        await apiConnector.deleteMedical(Medical.id!);
                        window.location.reload();
                    }}>
                        Delete
                    </Button>
                </td>
            </tr>
        </>
    )
}