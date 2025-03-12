import { useQuery } from "react-query";
import { getTestData } from "../services/api/test";

export default function useTest() {
  return useQuery({
    queryKey: ["repoData"],
    queryFn: getTestData,
  });
}
