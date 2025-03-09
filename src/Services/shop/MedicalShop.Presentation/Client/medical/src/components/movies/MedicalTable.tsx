import React, { useState, useEffect } from 'react';
import {Container, Button, Pagination, Dropdown} from 'semantic-ui-react';
import { NavLink } from 'react-router-dom';
import MedicalTableItem from './MedicalTableItem';
import {PaginationRequestParams} from "../../models/paginationResponse.ts";
import {MedicalDto} from "../../models/MedicalDto.ts";
import apiConnector from "../../api/apiConnector.ts";

export default function MedicalTable() {

    const [Medicals, setMedicals] = useState<MedicalDto[]>([]);
    const [totalPageNumber, setTotalPagesNumber] = useState(0);
    const [currentPage, setCurrentPage] = useState(1);
    const [pageSize, setPageSize] = useState(5);
    const [paginationRequestParams, setPaginationRequestParams] =
        useState<PaginationRequestParams>({ pageSize: pageSize, pageNumber: currentPage });

    const fetchData = async () => {
        const paginationResult = await apiConnector.getMedicals(paginationRequestParams);

        if (paginationResult.data) {
            const { data, paginationParams } = paginationResult;

        if (data && paginationParams) {
            setMedicals(data);
            setTotalPagesNumber(paginationParams.totalPages);
            setCurrentPage(paginationParams.currentPage);
            setPageSize(paginationParams.itemsPerPage);
        }}
    }

    useEffect(() => {
        fetchData();
    }, [paginationRequestParams]);

    const handlePageNumberChange = (_: React.MouseEvent<HTMLAnchorElement>, data: any) => {
        setPaginationRequestParams({ ...paginationRequestParams, pageNumber: data.activePage });
    }

    const handlePageSizeChange = (_: React.SyntheticEvent, data: any) => {
        setPaginationRequestParams({ ...paginationRequestParams, pageSize: data.value});
    };

    return (
        <>
            <Container className="container-style">
                <table className="ui inverted table">
                    <thead style={{textAlign: 'center'}}>
                    <tr>
                        <th>Id</th>
                        <th>Title</th>
                        <th>Description</th>
                        <th>CreateDate</th>
                        <th>Category</th>
                        <th>Action</th>
                    </tr>
                    </thead>
                    <tbody>
                    {Medicals.length !== 0 && (
                        Medicals.map((Medical, index) => (
                            <MedicalTableItem key={index} Medical={Medical}/>
                        ))
                    )}
                    </tbody>
                </table>
                <div
                    style={{marginTop: '20px', display: 'flex', justifyContent: 'space-between', alignItems: 'center'}}>
                    <Dropdown
                        selection
                        options={[
                            {key: 5, text: '5', value: 5},
                            {key: 10, text: '10', value: 10},
                            {key: 20, text: '20', value: 20},
                            {key: 30, text: '30', value: 30},
                        ]}
                        value={pageSize}
                        onChange={handlePageSizeChange}
                    />
                    <Pagination
                        activePage={currentPage}
                        totalPages={totalPageNumber}
                        onPageChange={handlePageNumberChange}
                    />
                    <Button as={NavLink} to="createMedical" floated="right" type="button" content="Create Medical"
                            positive/>
                </div>
            </Container>
        </>
    )
}