import useTest from "../../hooks/useTest";

export default function Test() {
  const { data, error, isLoading } = useTest();
console.log(data);

  return <>
  {
    data?.map((item)=>{
        return <div style={{color: 'red'}}>{item?.title} <br/></div>
    })
  }
  </>;
}
