import useSWR from "swr";

import fetcher from "@/lib/fetcher";

// fetchs data, igual ao react query,se os dados existirem nao vai usar de novo,
// nao precisamos de redux para gerir os estados

const useCurrentUser = () => {
  const { data, error, isLoading, mutate } = useSWR("/api/current", fetcher);

  return {
    data,
    error,
    isLoading,
    mutate,
  };
};

export default useCurrentUser;
