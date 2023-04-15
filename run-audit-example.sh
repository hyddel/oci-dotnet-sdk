#!/bin/bash

export OCI_COMPARTMENT_ID=$OCI_TENANCY
make build
cd Examples
dotnet run
