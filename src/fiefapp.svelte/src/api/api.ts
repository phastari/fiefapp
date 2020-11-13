const URL = 'https://localhost:5001/graphql';

export const postData = async (query: object): Promise<Response> => {
  const response = await fetch(URL, {
    method: 'POST',
    mode: 'same-origin',
    cache: 'no-cache',
    credentials: 'same-origin',
    headers: {
      'Content-Type': 'application/json',
    },
    redirect: 'error',
    referrerPolicy: 'no-referrer',
    body: JSON.stringify(query),
  });

  console.log('RESPONSE' + response);
  return response.json();
};
