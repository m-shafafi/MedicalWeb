import {MedicalDto} from "../models/MedicalDto.ts";
import {GetMedicalByIdResponse} from "../models/getMedicalByIdResponse.ts";
import {PaginationRequestParams, PaginationResult} from "../models/paginationResponse.ts";
import {AxiosResponse} from "axios";
import axiosInstance from "./axiosInstance.ts";

const apiConnector = {
    
    getMedicals: async (paginationRequestParams: PaginationRequestParams): Promise<PaginationResult<MedicalDto[]>> => {
        const response: AxiosResponse<PaginationResult<MedicalDto[]>> =
            await axiosInstance.get(`/Medicals?pageSize=${paginationRequestParams.pageSize}&pageNumber=${paginationRequestParams.pageNumber}`);

        if (response.data && Array.isArray(response.data.data)) {
            const modifiedData = response.data.data.map(Medical => ({
                ...Medical,
                createDate: Medical.createDate?.slice(0, 10) ?? ""
            }));

            return {
                ...response.data,
                data: modifiedData
            };
        } else {
                return {
                    data: [],
                    paginationParams: {
                        totalItems: 0,
                        totalPages: 0,
                        currentPage: 0,
                        itemsPerPage: 0
                    }
                };
        }
    },
    
    createMedical: async (Medical: MedicalDto): Promise<void> => {
        await axiosInstance.post<number>(`/Medicals`, Medical);
    },
    
    editMedical: async (Medical: MedicalDto) : Promise<void> => {
        await axiosInstance.put<number>(`/Medicals/${Medical.id}`, Medical);
    },
    
    deleteMedical: async (MedicalId: string): Promise<void> => {
        await axiosInstance.delete<number>(`/Medicals/${MedicalId}`);
        },
    
    getMedicalById: async (MedicalId: string) : Promise<MedicalDto | undefined> => {
            const response = await axiosInstance.get<GetMedicalByIdResponse>(`/Medicals/${MedicalId}`);
            return response.data.MedicalDto;
    }
}

export default apiConnector;