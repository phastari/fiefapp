import ApolloClient from 'apollo-client';
import { InMemoryCache } from 'apollo-cache-inmemory';
import { WebSocketLink } from 'apollo-link-ws';
import { split } from 'apollo-link';
import { HttpLink } from 'apollo-link-http';
import { getMainDefinition } from 'apollo-utilities';
import type { OperationDefinitionNode } from 'graphql';

const headers = { 'content-type': 'application/json' };
const getHeaders = () => {
  let token = localStorage.getItem('token');

  if (!token) {
    return headers;
  }

  return {
    headers: {
      ...headers,
      authorization: token ? `Bearer ${token}` : '',
    },
  };
};

const wsLink = new WebSocketLink({
  uri: 'ws://localhost:5000/graphql',
  options: {
    reconnect: true,
    lazy: true,
    connectionParams: () => {
      return { headers: getHeaders() };
    },
  },
});

const httpLink = new HttpLink({
  uri: 'http://localhost:5000/graphql',
  headers: getHeaders(),
});

const link = split(
  ({ query }) => {
    const definition = getMainDefinition(query);
    return (
      definition.kind === 'OperationDefinition' &&
      definition.operation === 'subscription'
    );
  },
  wsLink,
  httpLink
);

function isOperationDefintionNode(obj: any): obj is OperationDefinitionNode {
  return obj.operation !== undefined;
}

export const client = new ApolloClient({
  link,
  cache: new InMemoryCache(),
});
