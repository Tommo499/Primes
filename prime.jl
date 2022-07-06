function p(n)
	P = true
	if n == 2
		return true

	elseif n == 1
		return false

	elseif n == 0
		return false

	end
	for f = 2:ceil(Int, sqrt(n))
		P = true
		if mod(n, f) == 0
			P = false
			break
		end
	end
	return P
end