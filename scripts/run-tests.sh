#!/usr/bin/env bash
cd ./src/PartyInvites/ 
dotnet restore
dotnet build
dotnet test