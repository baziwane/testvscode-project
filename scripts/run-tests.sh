#!/usr/bin/env bash
cd ../tests/PartyInvites.Tests/ 
dotnet restore
dotnet build
dotnet test