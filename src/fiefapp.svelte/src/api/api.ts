const URL = 'http://localhost:5000/graphql';

export const postData = async (query: object): Promise<Response> => {
  const response = await fetch(URL, {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(query),
  });

  return response.json();
};
